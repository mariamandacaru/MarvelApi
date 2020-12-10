using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public static class Util
    {
        /// <summary>
        /// Returns the description attribute of an enum
        /// </summary>
        public static string GetDescription<T>(this T enumerationValue)
            where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();

        }

        /// <summary>
        /// Returns a list of integers given a string of numbers
        /// </summary>
        /// <param name="numberStr"></param>
        /// <returns></returns>
        public static List<int> GetIdList(string numberStr)
        {
            var idList = new List<int>();

            if (!string.IsNullOrEmpty(numberStr))
            {
                string[] splitted = numberStr.Split(',');
                for (int i = 0; i < splitted.Length; i++)
                {
                    int idOut;
                    if (int.TryParse(splitted[i], out idOut))
                        idList.Add(idOut);
                }
            }

            return idList;
        }
    }
}
