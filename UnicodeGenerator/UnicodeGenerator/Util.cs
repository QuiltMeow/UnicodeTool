using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace UnicodeGenerator
{
    public static class Util
    {
        // 移除零寬連字、不連字符號
        public static string removeCharacterWithoutDisplayWidth(this string data)
        {
            Regex regularExpression = new Regex(@"[\p{Cc}\p{Cf}\p{Mn}\p{Me}\p{Zl}\p{Zp}]");
            return regularExpression.Replace(data, string.Empty);
        }

        // Unicode 遍歷函式
        public static IEnumerable<string> textElement(this string data)
        {
            TextElementEnumerator enumerator = StringInfo.GetTextElementEnumerator(data);
            while (enumerator.MoveNext())
            {
                yield return enumerator.GetTextElement();
            }
        }

        public static string getUnicodeString(uint value)
        {
            return Encoding.UTF32.GetString(BitConverter.GetBytes(value));
        }

        public static void openForm(Type formType)
        {
            using (Form form = (Form)Activator.CreateInstance(formType)!)
            {
                form.ShowDialog();
            }
        }
    }
}