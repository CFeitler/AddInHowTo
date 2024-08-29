//AUTOGENERATED FILE. Do not make any manual changes. Any changes to this file will be overwritten.

using Scada.AddIn.Contracts.RecipeGroupManager;

namespace zenonExtensions
{
  public static class RecipeExtension
  {
/// Sets Recipe name
    public static void SetRecipeName(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("RecipeName", value);
    }

/// Gets Recipe name
    public static string GetRecipeName(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("RecipeName");
    }

/// Sets Recipe number
    public static void SetRecipeNumber(this IRecipe rGMRecipe, uint value)
    {
      rGMRecipe.SetDynamicProperty("RecipeNumber", value);
    }

/// Gets Recipe number
    public static uint GetRecipeNumber(this IRecipe rGMRecipe)
    {
      return (uint) rGMRecipe.GetDynamicProperty("RecipeNumber");
    }

/// Sets Recipe version
    public static void SetRecipeVersion(this IRecipe rGMRecipe, uint value)
    {
      rGMRecipe.SetDynamicProperty("RecipeVersion", value);
    }

/// Gets Recipe version
    public static uint GetRecipeVersion(this IRecipe rGMRecipe)
    {
      return (uint) rGMRecipe.GetDynamicProperty("RecipeVersion");
    }

/// Sets Status
    public static void SetStatus(this IRecipe rGMRecipe, ushort value)
    {
      rGMRecipe.SetDynamicProperty("Status", value);
    }

/// Gets Status
    public static ushort GetStatus(this IRecipe rGMRecipe)
    {
      return (ushort) rGMRecipe.GetDynamicProperty("Status");
    }

/// Sets TimeChange
    public static void SetTimeChange(this IRecipe rGMRecipe, double value)
    {
      rGMRecipe.SetDynamicProperty("TimeChange", value);
    }

/// Gets TimeChange
    public static double GetTimeChange(this IRecipe rGMRecipe)
    {
      return (double) rGMRecipe.GetDynamicProperty("TimeChange");
    }

/// Sets User for last change
    public static void SetUserChange(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("UserChange", value);
    }

/// Gets User for last change
    public static string GetUserChange(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("UserChange");
    }

/// Sets TimeSent
    public static void SetTimeSent(this IRecipe rGMRecipe, double value)
    {
      rGMRecipe.SetDynamicProperty("TimeSent", value);
    }

/// Gets TimeSent
    public static double GetTimeSent(this IRecipe rGMRecipe)
    {
      return (double) rGMRecipe.GetDynamicProperty("TimeSent");
    }

/// Sets User for last writing
    public static void SetUserSent(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("UserSent", value);
    }

/// Gets User for last writing
    public static string GetUserSent(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("UserSent");
    }

/// Sets Write synchronously
    public static void SetWriteSync(this IRecipe rGMRecipe, bool value)
    {
      rGMRecipe.SetDynamicProperty("WriteSync", value);
    }

/// Gets Write synchronously
    public static bool GetWriteSync(this IRecipe rGMRecipe)
    {
      return (bool) rGMRecipe.GetDynamicProperty("WriteSync");
    }

/// Sets WriteSync_IsLocal
    public static void SetWriteSync_IsLocal(this IRecipe rGMRecipe, bool value)
    {
      rGMRecipe.SetDynamicProperty("WriteSync_IsLocal", value);
    }

/// Gets WriteSync_IsLocal
    public static bool GetWriteSync_IsLocal(this IRecipe rGMRecipe)
    {
      return (bool) rGMRecipe.GetDynamicProperty("WriteSync_IsLocal");
    }

/// Sets Timeout [ms]
    public static void SetWriteTimeout(this IRecipe rGMRecipe, uint value)
    {
      rGMRecipe.SetDynamicProperty("WriteTimeout", value);
    }

/// Gets Timeout [ms]
    public static uint GetWriteTimeout(this IRecipe rGMRecipe)
    {
      return (uint) rGMRecipe.GetDynamicProperty("WriteTimeout");
    }

/// Sets WriteTimeout_IsLocal
    public static void SetWriteTimeout_IsLocal(this IRecipe rGMRecipe, bool value)
    {
      rGMRecipe.SetDynamicProperty("WriteTimeout_IsLocal", value);
    }

/// Gets WriteTimeout_IsLocal
    public static bool GetWriteTimeout_IsLocal(this IRecipe rGMRecipe)
    {
      return (bool) rGMRecipe.GetDynamicProperty("WriteTimeout_IsLocal");
    }

/// Sets Authorization level
    public static void SetPWLevel(this IRecipe rGMRecipe, ushort value)
    {
      rGMRecipe.SetDynamicProperty("PWLevel", value);
    }

/// Gets Authorization level
    public static ushort GetPWLevel(this IRecipe rGMRecipe)
    {
      return (ushort) rGMRecipe.GetDynamicProperty("PWLevel");
    }

/// Sets Comment 1
    public static void SetComment1(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment1", value);
    }

/// Gets Comment 1
    public static string GetComment1(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment1");
    }

/// Sets Comment 2
    public static void SetComment2(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment2", value);
    }

/// Gets Comment 2
    public static string GetComment2(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment2");
    }

/// Sets Comment 3
    public static void SetComment3(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment3", value);
    }

/// Gets Comment 3
    public static string GetComment3(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment3");
    }

/// Sets Comment 4
    public static void SetComment4(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment4", value);
    }

/// Gets Comment 4
    public static string GetComment4(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment4");
    }

/// Sets Comment 5
    public static void SetComment5(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment5", value);
    }

/// Gets Comment 5
    public static string GetComment5(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment5");
    }

/// Sets Comment 6
    public static void SetComment6(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment6", value);
    }

/// Gets Comment 6
    public static string GetComment6(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment6");
    }

/// Sets Comment 7
    public static void SetComment7(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment7", value);
    }

/// Gets Comment 7
    public static string GetComment7(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment7");
    }

/// Sets Comment 8
    public static void SetComment8(this IRecipe rGMRecipe, string value)
    {
      rGMRecipe.SetDynamicProperty("Comment8", value);
    }

/// Gets Comment 8
    public static string GetComment8(this IRecipe rGMRecipe)
    {
      return (string) rGMRecipe.GetDynamicProperty("Comment8");
    }

  }
}