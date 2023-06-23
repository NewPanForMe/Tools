using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Ys.Tools.MoreTool
{
    public class JsonTools
    {
        /// <summary>
        /// Json序列化配置
        /// </summary>
        private  static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions()
        {
            WriteIndented = true,//整齐打印
            //包含除使用西里尔字母以外所有西方国家的文字和亚洲中日韩越的文字
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.CjkUnifiedIdeographs),
            PropertyNameCaseInsensitive = true,//反序列化不区分大小写
            PropertyNamingPolicy=JsonNamingPolicy.CamelCase,//驼峰命名
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,//忽略null属性
            AllowTrailingCommas = false,// 不允许结尾有逗号的不标准json
            NumberHandling=JsonNumberHandling.AllowReadingFromString,//允许在反序列化的时候原本应为数字的字符串（带引号的数字）转为数字
            ReferenceHandler = ReferenceHandler.Preserve// 处理循环引用类型，比如Book类里面有一个属性也是Book类
        };

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="json"></param>
        public  static string Serialize(object json)
        {
           return JsonSerializer.Serialize(json, JsonOptions);
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            var deserialize = JsonSerializer.Deserialize<T>(json, JsonOptions);
            return deserialize;
        }
    }
}
