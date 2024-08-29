//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.ScreenElement;

namespace zenonExtensions
{
  public static class ScreenElementExtension
  {
/// Sets Style group
    public static void SetStyleGroup(this IScreenElement element, System.Guid value)
    {
      element.SetDynamicProperty("StyleGroup", value);
    }

/// Gets Style group
    public static System.Guid GetStyleGroup(this IScreenElement element)
    {
      return (System.Guid) element.GetDynamicProperty("StyleGroup");
    }

/// Sets Element ID
    public static void SetName(this IScreenElement element, string value)
    {
      element.SetDynamicProperty("Name", value);
    }

/// Gets Element ID
    public static string GetName(this IScreenElement element)
    {
      return (string) element.GetDynamicProperty("Name");
    }

/// Sets Visual name
    public static void SetVisualName(this IScreenElement element, string value)
    {
      element.SetDynamicProperty("VisualName", value);
    }

/// Gets Visual name
    public static string GetVisualName(this IScreenElement element)
    {
      return (string) element.GetDynamicProperty("VisualName");
    }

/// Sets Visibility level
    public static void SetLayer(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("Layer", value);
    }

/// Gets Visibility level
    public static byte GetLayer(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("Layer");
    }

/// Sets Equipment Groups
    public static void SetSystemModelGroup(this IScreenElement element, object value)
    {
      element.SetDynamicProperty("SystemModelGroup", value);
    }

/// Gets Equipment Groups
    public static object GetSystemModelGroup(this IScreenElement element)
    {
      return (object) element.GetDynamicProperty("SystemModelGroup");
    }

/// Sets Start point X [pixels]
    public static void SetStartX(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("StartX", value);
    }

/// Gets Start point X [pixels]
    public static int GetStartX(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("StartX");
    }

/// Sets End point X [pixels]
    public static void SetEndX(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("EndX", value);
    }

/// Gets End point X [pixels]
    public static int GetEndX(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("EndX");
    }

/// Sets Start point Y [pixels]
    public static void SetStartY(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("StartY", value);
    }

/// Gets Start point Y [pixels]
    public static int GetStartY(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("StartY");
    }

/// Sets End point Y [pixels]
    public static void SetEndY(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("EndY", value);
    }

/// Gets End point Y [pixels]
    public static int GetEndY(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("EndY");
    }

/// Sets Width [pixels]
    public static void SetWidth(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("Width", value);
    }

/// Gets Width [pixels]
    public static int GetWidth(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("Width");
    }

/// Sets Height [pixels]
    public static void SetHeight(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("Height", value);
    }

/// Gets Height [pixels]
    public static int GetHeight(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("Height");
    }

/// Sets Rotation angle [°]
    public static void SetAngle(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("Angle", value);
    }

/// Gets Rotation angle [°]
    public static int GetAngle(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("Angle");
    }

/// Sets Visible from
    public static void SetZoomMin(this IScreenElement element, short value)
    {
      element.SetDynamicProperty("ZoomMin", value);
    }

/// Gets Visible from
    public static short GetZoomMin(this IScreenElement element)
    {
      return (short) element.GetDynamicProperty("ZoomMin");
    }

/// Sets Visible to
    public static void SetZoomMax(this IScreenElement element, short value)
    {
      element.SetDynamicProperty("ZoomMax", value);
    }

/// Gets Visible to
    public static short GetZoomMax(this IScreenElement element)
    {
      return (short) element.GetDynamicProperty("ZoomMax");
    }

/// Sets Name for object list
    public static void SetStationname(this IScreenElement element, string value)
    {
      element.SetDynamicProperty("Stationname", value);
    }

/// Gets Name for object list
    public static string GetStationname(this IScreenElement element)
    {
      return (string) element.GetDynamicProperty("Stationname");
    }

/// Sets Display color preview
    public static void SetLineColorVarPreview(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("LineColorVarPreview", value);
    }

/// Gets Display color preview
    public static uint GetLineColorVarPreview(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("LineColorVarPreview");
    }

/// Sets Display color preview
    public static void SetBackColorVarPreview(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("BackColorVarPreview", value);
    }

/// Gets Display color preview
    public static uint GetBackColorVarPreview(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("BackColorVarPreview");
    }

/// Sets Horizontal
    public static void SetHorizontalOrigin(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("HorizontalOrigin", value);
    }

/// Gets Horizontal
    public static byte GetHorizontalOrigin(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("HorizontalOrigin");
    }

/// Sets Vertical
    public static void SetVerticalOrigin(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("VerticalOrigin", value);
    }

/// Gets Vertical
    public static byte GetVerticalOrigin(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("VerticalOrigin");
    }

/// Sets Visibility
    public static void SetVisibilityType(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("VisibilityType", value);
    }

/// Gets Visibility
    public static uint GetVisibilityType(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("VisibilityType");
    }

/// Sets Display visibility preview
    public static void SetVisVarPreview(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("VisVarPreview", value);
    }

/// Gets Display visibility preview
    public static uint GetVisVarPreview(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("VisVarPreview");
    }

/// Sets use limit value
    public static void SetVisibilityFromLimit(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("VisibilityFromLimit", value);
    }

/// Gets use limit value
    public static bool GetVisibilityFromLimit(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("VisibilityFromLimit");
    }

/// Sets from
    public static void SetVisibilityFrom(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("VisibilityFrom", value);
    }

/// Gets from
    public static double GetVisibilityFrom(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("VisibilityFrom");
    }

/// Sets to
    public static void SetVisibilityTo(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("VisibilityTo", value);
    }

/// Gets to
    public static double GetVisibilityTo(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("VisibilityTo");
    }

/// Sets Interlocking
    public static void SetInterlocking(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("Interlocking", value);
    }

/// Gets Interlocking
    public static uint GetInterlocking(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("Interlocking");
    }

/// Sets Interlocking
    public static void SetInterlockingName(this IScreenElement element, string value)
    {
      element.SetDynamicProperty("InterlockingName", value);
    }

/// Gets Interlocking
    public static string GetInterlockingName(this IScreenElement element)
    {
      return (string) element.GetDynamicProperty("InterlockingName");
    }

/// Sets Visible if interlocked
    public static void SetVisibleWhenInterlocked(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("VisibleWhenInterlocked", value);
    }

/// Gets Visible if interlocked
    public static bool GetVisibleWhenInterlocked(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("VisibleWhenInterlocked");
    }

/// Sets Display flash preview
    public static void SetBlinkVarPreview(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("BlinkVarPreview", value);
    }

/// Gets Display flash preview
    public static uint GetBlinkVarPreview(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("BlinkVarPreview");
    }

/// Sets Flashing color from limit value
    public static void SetUseBlinkColor(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("UseBlinkColor", value);
    }

/// Gets Flashing color from limit value
    public static bool GetUseBlinkColor(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("UseBlinkColor");
    }

/// Sets Min. variable value
    public static void SetXVarMin(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("XVarMin", value);
    }

/// Gets Min. variable value
    public static double GetXVarMin(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("XVarMin");
    }

/// Sets Max. variable value
    public static void SetXVarMax(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("XVarMax", value);
    }

/// Gets Max. variable value
    public static double GetXVarMax(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("XVarMax");
    }

/// Sets Min. movement [pixels]
    public static void SetXViewMin(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("XViewMin", value);
    }

/// Gets Min. movement [pixels]
    public static int GetXViewMin(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("XViewMin");
    }

/// Sets Max. movement [pixels]
    public static void SetXViewMax(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("XViewMax", value);
    }

/// Gets Max. movement [pixels]
    public static int GetXViewMax(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("XViewMax");
    }

/// Sets Min. variable value
    public static void SetYVarMin(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("YVarMin", value);
    }

/// Gets Min. variable value
    public static double GetYVarMin(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("YVarMin");
    }

/// Sets Max. variable value
    public static void SetYVarMax(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("YVarMax", value);
    }

/// Gets Max. variable value
    public static double GetYVarMax(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("YVarMax");
    }

/// Sets Min. movement [pixels]
    public static void SetYViewMin(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("YViewMin", value);
    }

/// Gets Min. movement [pixels]
    public static int GetYViewMin(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("YViewMin");
    }

/// Sets Max. movement [pixels]
    public static void SetYViewMax(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("YViewMax", value);
    }

/// Gets Max. movement [pixels]
    public static int GetYViewMax(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("YViewMax");
    }

/// Sets Min. variable value
    public static void SetXZoomVarMin(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("XZoomVarMin", value);
    }

/// Gets Min. variable value
    public static double GetXZoomVarMin(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("XZoomVarMin");
    }

/// Sets Max. variable value
    public static void SetXZoomVarMax(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("XZoomVarMax", value);
    }

/// Gets Max. variable value
    public static double GetXZoomVarMax(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("XZoomVarMax");
    }

/// Sets Min. width [%]
    public static void SetXZoomViewMin(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("XZoomViewMin", value);
    }

/// Gets Min. width [%]
    public static int GetXZoomViewMin(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("XZoomViewMin");
    }

/// Sets Max. width [%]
    public static void SetXZoomViewMax(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("XZoomViewMax", value);
    }

/// Gets Max. width [%]
    public static int GetXZoomViewMax(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("XZoomViewMax");
    }

/// Sets Min. variable value
    public static void SetYZoomVarMin(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("YZoomVarMin", value);
    }

/// Gets Min. variable value
    public static double GetYZoomVarMin(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("YZoomVarMin");
    }

/// Sets Max. variable value
    public static void SetYZoomVarMax(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("YZoomVarMax", value);
    }

/// Gets Max. variable value
    public static double GetYZoomVarMax(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("YZoomVarMax");
    }

/// Sets Min. height [%]
    public static void SetYZoomViewMin(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("YZoomViewMin", value);
    }

/// Gets Min. height [%]
    public static int GetYZoomViewMin(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("YZoomViewMin");
    }

/// Sets Max. height [%]
    public static void SetYZoomViewMax(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("YZoomViewMax", value);
    }

/// Gets Max. height [%]
    public static int GetYZoomViewMax(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("YZoomViewMax");
    }

/// Sets Min. variable value
    public static void SetTwistVarMin(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("TwistVarMin", value);
    }

/// Gets Min. variable value
    public static double GetTwistVarMin(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("TwistVarMin");
    }

/// Sets Max. variable value
    public static void SetTwistVarMax(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("TwistVarMax", value);
    }

/// Gets Max. variable value
    public static double GetTwistVarMax(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("TwistVarMax");
    }

/// Sets Min. rotation [°]
    public static void SetTwistViewMin(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("TwistViewMin", value);
    }

/// Gets Min. rotation [°]
    public static int GetTwistViewMin(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("TwistViewMin");
    }

/// Sets Max. rotation [°]
    public static void SetTwistViewMax(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("TwistViewMax", value);
    }

/// Gets Max. rotation [°]
    public static int GetTwistViewMax(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("TwistViewMax");
    }

/// Sets Borders/shadows effect style
    public static void SetShadowEffectStyle(this IScreenElement element, System.Guid value)
    {
      element.SetDynamicProperty("ShadowEffectStyle", value);
    }

/// Gets Borders/shadows effect style
    public static System.Guid GetShadowEffectStyle(this IScreenElement element)
    {
      return (System.Guid) element.GetDynamicProperty("ShadowEffectStyle");
    }

/// Sets Border type
    public static void SetPunchFrameType(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("PunchFrameType", value);
    }

/// Gets Border type
    public static byte GetPunchFrameType(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("PunchFrameType");
    }

/// Sets Display border
    public static void SetEnablePunchFrame(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("EnablePunchFrame", value);
    }

/// Gets Display border
    public static bool GetEnablePunchFrame(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("EnablePunchFrame");
    }

/// Sets Border/shadow color
    public static void SetPunchFrameColor(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("PunchFrameColor", value);
    }

/// Gets Border/shadow color
    public static uint GetPunchFrameColor(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("PunchFrameColor");
    }

/// Sets Transparency [%]
    public static void SetPunchFrameAlpha(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("PunchFrameAlpha", value);
    }

/// Gets Transparency [%]
    public static byte GetPunchFrameAlpha(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("PunchFrameAlpha");
    }

/// Sets Line width [pixels]
    public static void SetPunchFrameWidth(this IScreenElement element, ushort value)
    {
      element.SetDynamicProperty("PunchFrameWidth", value);
    }

/// Gets Line width [pixels]
    public static ushort GetPunchFrameWidth(this IScreenElement element)
    {
      return (ushort) element.GetDynamicProperty("PunchFrameWidth");
    }

/// Sets Blur
    public static void SetPunchFrameSoftFocus(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("PunchFrameSoftFocus", value);
    }

/// Gets Blur
    public static byte GetPunchFrameSoftFocus(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("PunchFrameSoftFocus");
    }

/// Sets Distance [pixels]
    public static void SetPunchFrameOffset(this IScreenElement element, ushort value)
    {
      element.SetDynamicProperty("PunchFrameOffset", value);
    }

/// Gets Distance [pixels]
    public static ushort GetPunchFrameOffset(this IScreenElement element)
    {
      return (ushort) element.GetDynamicProperty("PunchFrameOffset");
    }

/// Sets Angle [°]
    public static void SetPunchFrameAngle(this IScreenElement element, short value)
    {
      element.SetDynamicProperty("PunchFrameAngle", value);
    }

/// Gets Angle [°]
    public static short GetPunchFrameAngle(this IScreenElement element)
    {
      return (short) element.GetDynamicProperty("PunchFrameAngle");
    }

/// Sets Shadow size [%]
    public static void SetPunchFrameSize(this IScreenElement element, int value)
    {
      element.SetDynamicProperty("PunchFrameSize", value);
    }

/// Gets Shadow size [%]
    public static int GetPunchFrameSize(this IScreenElement element)
    {
      return (int) element.GetDynamicProperty("PunchFrameSize");
    }

/// Sets Glow effect style
    public static void SetGlowEffectStyle(this IScreenElement element, System.Guid value)
    {
      element.SetDynamicProperty("GlowEffectStyle", value);
    }

/// Gets Glow effect style
    public static System.Guid GetGlowEffectStyle(this IScreenElement element)
    {
      return (System.Guid) element.GetDynamicProperty("GlowEffectStyle");
    }

/// Sets Activate
    public static void SetGlowEffectActive(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("GlowEffectActive", value);
    }

/// Gets Activate
    public static bool GetGlowEffectActive(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("GlowEffectActive");
    }

/// Sets Active if clicked only
    public static void SetGlowEffectEvent(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("GlowEffectEvent", value);
    }

/// Gets Active if clicked only
    public static bool GetGlowEffectEvent(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("GlowEffectEvent");
    }

/// Sets Transparency [%]
    public static void SetGlowEffectAlpha(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("GlowEffectAlpha", value);
    }

/// Gets Transparency [%]
    public static byte GetGlowEffectAlpha(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("GlowEffectAlpha");
    }

/// Sets Spread [pixels]
    public static void SetGlowEffectSpread(this IScreenElement element, byte value)
    {
      element.SetDynamicProperty("GlowEffectSpread", value);
    }

/// Gets Spread [pixels]
    public static byte GetGlowEffectSpread(this IScreenElement element)
    {
      return (byte) element.GetDynamicProperty("GlowEffectSpread");
    }

/// Sets Coloring
    public static void SetGlowEffectUseColor(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("GlowEffectUseColor", value);
    }

/// Gets Coloring
    public static bool GetGlowEffectUseColor(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("GlowEffectUseColor");
    }

/// Sets Color
    public static void SetGlowEffectColor(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("GlowEffectColor", value);
    }

/// Gets Color
    public static uint GetGlowEffectColor(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("GlowEffectColor");
    }

/// Sets Display color preview
    public static void SetGlowEffectGlowColorVariablePreview(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("GlowEffectGlowColorVariablePreview", value);
    }

/// Gets Display color preview
    public static uint GetGlowEffectGlowColorVariablePreview(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("GlowEffectGlowColorVariablePreview");
    }

/// Sets Display visibility preview
    public static void SetGlowEffectVisibilityVariablePreview(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("GlowEffectVisibilityVariablePreview", value);
    }

/// Gets Display visibility preview
    public static uint GetGlowEffectVisibilityVariablePreview(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("GlowEffectVisibilityVariablePreview");
    }

/// Sets Use visibility from limit value
    public static void SetGlowEffectVisibilityFromLimit(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("GlowEffectVisibilityFromLimit", value);
    }

/// Gets Use visibility from limit value
    public static bool GetGlowEffectVisibilityFromLimit(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("GlowEffectVisibilityFromLimit");
    }

/// Sets Visible from
    public static void SetGlowEffectVisibilityFrom(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("GlowEffectVisibilityFrom", value);
    }

/// Gets Visible from
    public static double GetGlowEffectVisibilityFrom(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("GlowEffectVisibilityFrom");
    }

/// Sets Visible to
    public static void SetGlowEffectVisibilityTo(this IScreenElement element, double value)
    {
      element.SetDynamicProperty("GlowEffectVisibilityTo", value);
    }

/// Gets Visible to
    public static double GetGlowEffectVisibilityTo(this IScreenElement element)
    {
      return (double) element.GetDynamicProperty("GlowEffectVisibilityTo");
    }

/// Sets Display flash preview
    public static void SetGlowEffectBlinkVariablePreview(this IScreenElement element, uint value)
    {
      element.SetDynamicProperty("GlowEffectBlinkVariablePreview", value);
    }

/// Gets Display flash preview
    public static uint GetGlowEffectBlinkVariablePreview(this IScreenElement element)
    {
      return (uint) element.GetDynamicProperty("GlowEffectBlinkVariablePreview");
    }

/// Sets Use flashing color from limit value
    public static void SetGlowEffectUseBlinkColor(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("GlowEffectUseBlinkColor", value);
    }

/// Gets Use flashing color from limit value
    public static bool GetGlowEffectUseBlinkColor(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("GlowEffectUseBlinkColor");
    }

/// Sets 2. flash state invisible
    public static void SetGlowEffect2ndBlinkStateVisible(this IScreenElement element, bool value)
    {
      element.SetDynamicProperty("GlowEffect2ndBlinkStateVisible", value);
    }

/// Gets 2. flash state invisible
    public static bool GetGlowEffect2ndBlinkStateVisible(this IScreenElement element)
    {
      return (bool) element.GetDynamicProperty("GlowEffect2ndBlinkStateVisible");
    }

/// Sets Variable
    public static void SetProjectVar(this IScreenElement element, object value)
    {
      element.SetDynamicProperty("ProjectVar", value);
    }

/// Gets Variable
    public static object GetProjectVar(this IScreenElement element)
    {
      return (object) element.GetDynamicProperty("ProjectVar");
    }

/// Sets SymVarName
    public static void SetSymVarName(this IScreenElement element, string value)
    {
      element.SetDynamicProperty("SymVarName", value);
    }

/// Gets SymVarName
    public static string GetSymVarName(this IScreenElement element)
    {
      return (string) element.GetDynamicProperty("SymVarName");
    }

/// Sets Variable
    public static void SetSymVarTagNr(this IScreenElement element, string value)
    {
      element.SetDynamicProperty("SymVarTagNr", value);
    }

/// Gets Variable
    public static string GetSymVarTagNr(this IScreenElement element)
    {
      return (string) element.GetDynamicProperty("SymVarTagNr");
    }

  }
}