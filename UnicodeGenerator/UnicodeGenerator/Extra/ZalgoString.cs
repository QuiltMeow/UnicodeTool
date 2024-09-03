using System.Text;

namespace UnicodeGenerator
{
    public class ZalgoString
    {
        public static readonly char[] zalgoUp =
        {
            (char) 0x030D, (char) 0x030E, (char) 0x0304, (char) 0x0305,
            (char) 0x033F, (char) 0x0311, (char) 0x0306, (char) 0x0310,
            (char) 0x0352, (char) 0x0357, (char) 0x0351, (char) 0x0307,
            (char) 0x0308, (char) 0x030A, (char) 0x0342, (char) 0x0343,
            (char) 0x0344, (char) 0x034A, (char) 0x034B, (char) 0x034C,
            (char) 0x0303, (char) 0x0302, (char) 0x030C, (char) 0x0350,
            (char) 0x0300, (char) 0x0301, (char) 0x030B, (char) 0x030F,
            (char) 0x0312, (char) 0x0313, (char) 0x0314, (char) 0x033D,
            (char) 0x0309, (char) 0x0363, (char) 0x0364, (char) 0x0365,
            (char) 0x0366, (char) 0x0367, (char) 0x0368, (char) 0x0369,
            (char) 0x036A, (char) 0x036B, (char) 0x036C, (char) 0x036D,
            (char) 0x036E, (char) 0x036F, (char) 0x033E, (char) 0x035B
        };

        public static readonly char[] zalgoDown =
        {
            (char) 0x0316, (char) 0x0317, (char) 0x0318, (char) 0x0319,
            (char) 0x031C, (char) 0x031D, (char) 0x031E, (char) 0x031F,
            (char) 0x0320, (char) 0x0324, (char) 0x0325, (char) 0x0326,
            (char) 0x0329, (char) 0x032A, (char) 0x032B, (char) 0x032C,
            (char) 0x032D, (char) 0x032E, (char) 0x032F, (char) 0x0330,
            (char) 0x0331, (char) 0x0332, (char) 0x0333, (char) 0x0339,
            (char) 0x033A, (char) 0x033B, (char) 0x033C, (char) 0x0345,
            (char) 0x0347, (char) 0x0348, (char) 0x0349, (char) 0x034D,
            (char) 0x034E, (char) 0x0353, (char) 0x0354, (char) 0x0355,
            (char) 0x0356, (char) 0x0359, (char) 0x035A, (char) 0x0323
        };

        public static readonly char[] zalgoMedium =
        {
            (char) 0x0315, (char) 0x031B, (char) 0x0340, (char) 0x0341,
            (char) 0x0358, (char) 0x0321, (char) 0x0322, (char) 0x0327,
            (char) 0x0328, (char) 0x0334, (char) 0x0335, (char) 0x0336,
            (char) 0x034F, (char) 0x035C, (char) 0x035D, (char) 0x035E,
            (char) 0x035F, (char) 0x0360, (char) 0x0362, (char) 0x0338,
            (char) 0x0337, (char) 0x0361, (char) 0x0489
        };

        public int upCountMax
        {
            get;
            set;
        }

        public int mediumCountMax
        {
            get;
            set;
        }

        public int downCountMax
        {
            get;
            set;
        }

        public string text
        {
            get;
            private set;
        }

        public ZalgoString(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("空字串");
            }
            this.text = text;
        }

        public enum TextMode
        {
            UP,
            MEDIUM,
            DOWN
        }

        public string generateZalgoCharacter()
        {
            StringBuilder ret = new StringBuilder();
            Random random = Random.Shared;
            int upCount = 0;
            int upLength = random.Next(upCountMax + 1);

            int mediumCount = 0;
            int mediumLength = random.Next(mediumCountMax + 1);

            int downCount = 0;
            int downLength = random.Next(downCountMax + 1);

            while (upCount != upLength || mediumCount != mediumLength || downCount != downLength)
            {
                TextMode select = (TextMode)random.Next(Enum.GetNames(typeof(TextMode)).Length);
                switch (select)
                {
                    case TextMode.UP:
                        {
                            if (upCount >= upLength)
                            {
                                continue;
                            }
                            ret.Append(zalgoUp[random.Next(zalgoUp.Length)]);
                            ++upCount;
                            break;
                        }
                    case TextMode.MEDIUM:
                        {
                            if (mediumCount >= mediumLength)
                            {
                                continue;
                            }
                            ret.Append(zalgoMedium[random.Next(zalgoMedium.Length)]);
                            ++mediumCount;
                            break;
                        }
                    case TextMode.DOWN:
                        {
                            if (downCount >= downLength)
                            {
                                continue;
                            }
                            ret.Append(zalgoDown[random.Next(zalgoDown.Length)]);
                            ++downCount;
                            break;
                        }
                }
            }
            return ret.ToString();
        }

        public string convert()
        {
            StringBuilder ret = new StringBuilder();
            foreach (string value in text.textElement())
            {
                ret.Append(value).Append(generateZalgoCharacter());
            }
            return ret.ToString();
        }
    }
}