using System.Text.Json;

namespace Ys.Tools.Extra
{
    public static class JsonElementExtra
    {
        public static string GetJsonString(this JsonElement json, string value)
        {
            return json.GetProperty(value).GetString();
        }
        public static int GetJsonNum(this JsonElement json, string value)
        {
            return json.GetProperty(value).GetInt32();
        }
        public static bool GetJsonBool(this JsonElement json, string value)
        {
            return json.GetProperty(value).GetBoolean();
        }
    }
}