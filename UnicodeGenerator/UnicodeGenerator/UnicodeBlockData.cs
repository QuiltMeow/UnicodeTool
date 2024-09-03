namespace UnicodeGenerator
{
    public class UnicodeBlockData
    {
        public string plane
        {
            get;
            private set;
        }

        public string readableBlockRange
        {
            get;
            private set;
        }

        public string blockName
        {
            get;
            private set;
        }

        public uint lower
        {
            get;
            private set;
        }

        public uint upper
        {
            get;
            private set;
        }

        public bool defaultCheck
        {
            get;
            private set;
        }

        public UnicodeBlockData(string plane, string readableBlockRange, string blockName, bool defaultCheck = false)
        {
            this.plane = plane;
            this.readableBlockRange = readableBlockRange;
            this.blockName = blockName;
            this.defaultCheck = defaultCheck;
            initializeIntegerRange();
        }

        public void initializeIntegerRange()
        {
            string[] range = readableBlockRange.Replace("U+", string.Empty).Split('～');
            lower = Convert.ToUInt32(range[0], 16);
            upper = Convert.ToUInt32(range[1], 16);
        }
    }
}