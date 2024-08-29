//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.TimeModel;

namespace zenonExtensions
{
  public static class TimeFunctionExtension
  {
/// Sets Active
    public static void SetActive(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Active", value);
    }

/// Gets Active
    public static bool GetActive(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Active");
    }

/// Sets Name
    public static void SetName(this ITimeFunction timeFunction, string value)
    {
      timeFunction.SetDynamicProperty("Name", value);
    }

/// Gets Name
    public static string GetName(this ITimeFunction timeFunction)
    {
      return (string) timeFunction.GetDynamicProperty("Name");
    }

/// Sets Equipment Groups
    public static void SetSystemModelGroup(this ITimeFunction timeFunction, object value)
    {
      timeFunction.SetDynamicProperty("SystemModelGroup", value);
    }

/// Gets Equipment Groups
    public static object GetSystemModelGroup(this ITimeFunction timeFunction)
    {
      return (object) timeFunction.GetDynamicProperty("SystemModelGroup");
    }

/// Sets Execution type
    public static void SetType(this ITimeFunction timeFunction, int value)
    {
      timeFunction.SetDynamicProperty("Type", value);
    }

/// Gets Execution type
    public static int GetType(this ITimeFunction timeFunction)
    {
      return (int) timeFunction.GetDynamicProperty("Type");
    }

/// Sets Start time
    public static void SetExecuteDate(this ITimeFunction timeFunction, uint value)
    {
      timeFunction.SetDynamicProperty("ExecuteDate", value);
    }

/// Gets Start time
    public static uint GetExecuteDate(this ITimeFunction timeFunction)
    {
      return (uint) timeFunction.GetDynamicProperty("ExecuteDate");
    }

/// Sets interval
    public static void SetInterval(this ITimeFunction timeFunction, uint value)
    {
      timeFunction.SetDynamicProperty("Interval", value);
    }

/// Gets interval
    public static uint GetInterval(this ITimeFunction timeFunction)
    {
      return (uint) timeFunction.GetDynamicProperty("Interval");
    }

/// Sets Interval one month
    public static void SetMonthly(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Monthly", value);
    }

/// Gets Interval one month
    public static bool GetMonthly(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Monthly");
    }

/// Sets Interval one year
    public static void SetYearly(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Yearly", value);
    }

/// Gets Interval one year
    public static bool GetYearly(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Yearly");
    }

/// Sets Monday
    public static void SetMonday(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Monday", value);
    }

/// Gets Monday
    public static bool GetMonday(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Monday");
    }

/// Sets Tuesday
    public static void SetTuesday(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Tuesday", value);
    }

/// Gets Tuesday
    public static bool GetTuesday(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Tuesday");
    }

/// Sets Wednesday
    public static void SetWednesday(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Wednesday", value);
    }

/// Gets Wednesday
    public static bool GetWednesday(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Wednesday");
    }

/// Sets Thursday
    public static void SetThursday(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Thursday", value);
    }

/// Gets Thursday
    public static bool GetThursday(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Thursday");
    }

/// Sets Friday
    public static void SetFriday(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Friday", value);
    }

/// Gets Friday
    public static bool GetFriday(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Friday");
    }

/// Sets Saturday
    public static void SetSaturday(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Saturday", value);
    }

/// Gets Saturday
    public static bool GetSaturday(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Saturday");
    }

/// Sets Sunday
    public static void SetSunday(this ITimeFunction timeFunction, bool value)
    {
      timeFunction.SetDynamicProperty("Sunday", value);
    }

/// Gets Sunday
    public static bool GetSunday(this ITimeFunction timeFunction)
    {
      return (bool) timeFunction.GetDynamicProperty("Sunday");
    }

  }
}