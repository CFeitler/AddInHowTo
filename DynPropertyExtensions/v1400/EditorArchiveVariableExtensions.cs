//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.Historian;

namespace zenonExtensions
{
  public static class EditorArchiveVariableExtension
  {
/// Sets Calculation
    public static void SetCalculation(this IEditorArchiveVariable archiveVarED, byte value)
    {
      archiveVarED.SetDynamicProperty("Calculation", value);
    }

/// Gets Calculation
    public static byte GetCalculation(this IEditorArchiveVariable archiveVarED)
    {
      return (byte) archiveVarED.GetDynamicProperty("Calculation");
    }

/// Sets Variable
    public static void SetVariable(this IEditorArchiveVariable archiveVarED, object value)
    {
      archiveVarED.SetDynamicProperty("Variable", value);
    }

/// Gets Variable
    public static object GetVariable(this IEditorArchiveVariable archiveVarED)
    {
      return (object) archiveVarED.GetDynamicProperty("Variable");
    }

  }
}