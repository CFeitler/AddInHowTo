//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.AlarmMessageList;

namespace zenonExtensions
{
  public static class AlarmMessageListExtension
  {
/// Sets QueryFilter
    public static void SetQueryFilter(this IAlarmMessageList alarm, object value)
    {
      alarm.SetDynamicProperty("QueryFilter", value);
    }

/// Gets QueryFilter
    public static object GetQueryFilter(this IAlarmMessageList alarm)
    {
      return (object) alarm.GetDynamicProperty("QueryFilter");
    }

  }
}