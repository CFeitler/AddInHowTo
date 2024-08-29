//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.EquipmentModeling;

namespace zenonExtensions
{
  public static class EquipmentGroupExtension
  {
/// Sets Status variable
    public static void SetStatusVar(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("StatusVar", value);
    }

/// Gets Status variable
    public static object GetStatusVar(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("StatusVar");
    }

/// Sets Number of active alarms
    public static void SetAlarmVar(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("AlarmVar", value);
    }

/// Gets Number of active alarms
    public static object GetAlarmVar(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("AlarmVar");
    }

/// Sets Number of unacknowledged alarms
    public static void SetQuitVar(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("QuitVar", value);
    }

/// Gets Number of unacknowledged alarms
    public static object GetQuitVar(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("QuitVar");
    }

/// Sets Number of shelved alarms
    public static void SetShelvedAlarmsCounterVariable(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("ShelvedAlarmsCounterVariable", value);
    }

/// Gets Number of shelved alarms
    public static object GetShelvedAlarmsCounterVariable(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("ShelvedAlarmsCounterVariable");
    }

/// Sets Name
    public static void SetName(this IEquipmentGroup systemModelGroup, string value)
    {
      systemModelGroup.SetDynamicProperty("Name", value);
    }

/// Gets Name
    public static string GetName(this IEquipmentGroup systemModelGroup)
    {
      return (string) systemModelGroup.GetDynamicProperty("Name");
    }

/// Sets Equipment Groups
    public static void SetSystemModelGroup(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("SystemModelGroup", value);
    }

/// Gets Equipment Groups
    public static object GetSystemModelGroup(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("SystemModelGroup");
    }

/// Sets Guid
    public static void SetGuid(this IEquipmentGroup systemModelGroup, string value)
    {
      systemModelGroup.SetDynamicProperty("Guid", value);
    }

/// Gets Guid
    public static string GetGuid(this IEquipmentGroup systemModelGroup)
    {
      return (string) systemModelGroup.GetDynamicProperty("Guid");
    }

/// Sets Type
    public static void SetEquipmentGroupType(this IEquipmentGroup systemModelGroup, short value)
    {
      systemModelGroup.SetDynamicProperty("EquipmentGroupType", value);
    }

/// Gets Type
    public static short GetEquipmentGroupType(this IEquipmentGroup systemModelGroup)
    {
      return (short) systemModelGroup.GetDynamicProperty("EquipmentGroupType");
    }

/// Sets Available at this computer
    public static void SetAuthorizationAvailable(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("AuthorizationAvailable", value);
    }

/// Gets Available at this computer
    public static object GetAuthorizationAvailable(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("AuthorizationAvailable");
    }

/// Sets Operating authorization at computer
    public static void SetAuthorizationOwner(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("AuthorizationOwner", value);
    }

/// Gets Operating authorization at computer
    public static object GetAuthorizationOwner(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("AuthorizationOwner");
    }

/// Sets Number of pending maintenances
    public static void SetIMMMaintCount(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("IMMMaintCount", value);
    }

/// Gets Number of pending maintenances
    public static object GetIMMMaintCount(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("IMMMaintCount");
    }

/// Sets Total number of pending maintenances
    public static void SetIMMMaintCountRecursive(this IEquipmentGroup systemModelGroup, object value)
    {
      systemModelGroup.SetDynamicProperty("IMMMaintCountRecursive", value);
    }

/// Gets Total number of pending maintenances
    public static object GetIMMMaintCountRecursive(this IEquipmentGroup systemModelGroup)
    {
      return (object) systemModelGroup.GetDynamicProperty("IMMMaintCountRecursive");
    }

/// Sets ClassName
    public static void SetClassName(this IEquipmentGroup systemModelGroup, string value)
    {
      systemModelGroup.SetDynamicProperty("ClassName", value);
    }

/// Gets ClassName
    public static string GetClassName(this IEquipmentGroup systemModelGroup)
    {
      return (string) systemModelGroup.GetDynamicProperty("ClassName");
    }

/// Sets Alarm/event class
    public static void SetClass(this IEquipmentGroup systemModelGroup, ushort value)
    {
      systemModelGroup.SetDynamicProperty("Class", value);
    }

/// Gets Alarm/event class
    public static ushort GetClass(this IEquipmentGroup systemModelGroup)
    {
      return (ushort) systemModelGroup.GetDynamicProperty("Class");
    }

  }
}