using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }


    public class ActionRequest
    {
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        public ActionRequest()
        {

        }
        public ActionRequest(Guid requestID)
        {
            requestID = new Guid();
        }
        public ActionRequest(Guid requestID, ActionEnum actionEnum, int number, string phrase, string input)
        {
            switch (actionEnum)
            {
                case ActionEnum.Convert:
                    convert = Convert(number);
                    break;
                case ActionEnum.Uppercase:
                    upperCase = UpperCase(phrase);
                    break;
                case ActionEnum.Reverse:
                    reverse = Reverse(input);
                    break;
                default:
                    break;
            }

        }



    }
}
