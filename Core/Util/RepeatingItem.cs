using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Util
{
    class RepeatingItem
    {
        public string Title { get; set; }
        public int Code { get; set; }
        public int Index {
            get {
                return convertCodeToIndex();
            }
        }

        public RepeatingItem(string Title, int Code)
        {
            this.Title = Title;
            this.Code = Code;
        }

        public const int CODE_NEVER = 100;
        public const int CODE_DAILY = 200;
        public const int CODE_WEEKLY = 300;
        public const int CODE_MONTHLY = 400;
        public const int CODE_BI_YEARLY = 500;
        public const int CODE_YEARLY = 600;

        private int convertCodeToIndex()
        {
            switch (Code)
            {
                case CODE_NEVER:
                    return 0;
                case CODE_DAILY:
                    return 1;
                case CODE_WEEKLY:
                    return 2;
                case CODE_MONTHLY:
                    return 3;
                case CODE_BI_YEARLY:
                    return 4;
                case CODE_YEARLY:
                    return 5;
                default:
                    return 3;
                
            }
        }

        public static IList<RepeatingItem> GetItems()
        {
            IList<RepeatingItem> repeatingItems = new List<RepeatingItem>();
            repeatingItems.Add(new RepeatingItem(ConvertCodeToString(CODE_NEVER), CODE_NEVER));
            repeatingItems.Add(new RepeatingItem(ConvertCodeToString(CODE_DAILY), CODE_DAILY));
            repeatingItems.Add(new RepeatingItem(ConvertCodeToString(CODE_WEEKLY), CODE_WEEKLY));
            repeatingItems.Add(new RepeatingItem(ConvertCodeToString(CODE_MONTHLY), CODE_MONTHLY));
            repeatingItems.Add(new RepeatingItem(ConvertCodeToString(CODE_BI_YEARLY), CODE_BI_YEARLY));
            repeatingItems.Add(new RepeatingItem(ConvertCodeToString(CODE_YEARLY), CODE_YEARLY));

            return repeatingItems;
        }

        public static string ConvertCodeToString(int code)
        {
            switch (code)
            {
                case CODE_NEVER:
                    return "Never";
                case CODE_DAILY:
                    return "Daily";
                case CODE_WEEKLY:
                    return "Weekly";
                case CODE_MONTHLY:
                    return "Monthly";
                case CODE_BI_YEARLY:
                    return "Bi-Yearly";
                case CODE_YEARLY:
                    return "Yearly";
                default:
                    return "Monthly";
            }
        }
    }
}
