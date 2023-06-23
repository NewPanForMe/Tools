namespace Ys.Tools.Exception
{
    /// <summary>
    /// 用于发出文字性错误
    /// 全局
    /// </summary>
    public class MessageException:System.Exception
    {
        public MessageException(string message):base(message) { }

        public static MessageException Throw(string message) { 
            throw new MessageException(message);
        }
    }
}
