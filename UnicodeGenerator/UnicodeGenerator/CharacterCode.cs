using System.Globalization;
using System.Text;

namespace UnicodeGenerator
{
    public class CharacterCode
    {
        public string character
        {
            get;
            private set;
        }

        public string? characterUnicodeValue
        {
            get;
            private set;
        }

        public byte[] characterUTF8Byte
        {
            get;
            private set;
        }

        public byte[]? characterUTF16Byte
        {
            get;
            private set;
        }

        public byte[] characterUTF32Byte
        {
            get;
            private set;
        }

        public uint? characterUnicodeIntegerValue
        {
            get;
            private set;
        }

        public CharacterCode(string unicodeCharacter)
        {
            character = unicodeCharacter;
            StringInfo si = new StringInfo(character);
            if (si.LengthInTextElements != 1)
            {
                throw new ArgumentException("空字元或多個字元");
            }
            characterUTF8Byte = Encoding.UTF8.GetBytes(character);
            characterUTF16Byte = getReadableUTF16ByteArray(Encoding.Unicode.GetBytes(character));
            characterUTF32Byte = endianConvert(Encoding.UTF32.GetBytes(character));

            characterUnicodeIntegerValue = getCharacterUnicodeIntegerValue();
            characterUnicodeValue = getCharacterUnicodeValue();
        }

        public static byte[]? getReadableUTF16ByteArray(byte[] utf16ByteArray)
        {
            if (utf16ByteArray.Length > sizeof(uint))
            {
                return null;
            }
            else if (utf16ByteArray.Length > 2)
            {
                return [utf16ByteArray[1], utf16ByteArray[0], utf16ByteArray[3], utf16ByteArray[2]];
            }
            else
            {
                return endianConvert(utf16ByteArray);
            }
        }

        private uint? getCharacterUnicodeIntegerValue()
        {
            if (characterUTF32Byte.Length > sizeof(uint))
            {
                return null;
            }
            try
            {
                return (uint)char.ConvertToUtf32(character, 0);
            }
            catch
            {
                return null;
            }
        }

        private string? getCharacterUnicodeValue()
        {
            uint? value = characterUnicodeIntegerValue;
            if (value == null)
            {
                return null;
            }
            return $"U+{value.Value:X4}";
        }

        // 大小端序轉換
        public static byte[] endianConvert(byte[] data)
        {
            int length = data.Length;
            byte[] ret = new byte[length];
            Array.Copy(data, 0, ret, 0, length);
            Array.Reverse(ret, 0, length);
            return ret;
        }
    }
}