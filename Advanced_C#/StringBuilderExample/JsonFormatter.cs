using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    public class JsonFormatter
    {
        public static string Converter(object obj)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            ObjectTojsonConverter(obj, jsonBuilder);
            return jsonBuilder.ToString();
        }

        private static void ObjectTojsonConverter(object obj, StringBuilder jsonBuilder)
        {
            if (obj is null)
            {
                jsonBuilder.Append("null");
                return;
            }
            Type objeType = obj.GetType();

            if (objeType.IsPrimitive || objeType == typeof(string) || objeType == typeof(DateTime))
            {
                AppendToPrimitive(obj, jsonBuilder);
            }
            else if (objeType.IsArray)
            {
                ConvertToArray((Array) obj, jsonBuilder);
            }
            else if (obj is IEnumerable enumerable)
            {
                ConvertToCollection(enumerable, jsonBuilder);
            }
            else if(objeType.IsClass)
            {
                ConvertToObject(obj, jsonBuilder);
            }
        }

        private static void AppendToPrimitive(object obj, StringBuilder jsonBuilder)
        {
            if (obj is string)
            {
                jsonBuilder.Append('"').Append(obj).Append('"');
            }
            else if (obj is DateTime dateTime)
            {
                jsonBuilder.Append('"').Append(dateTime.ToString("yyyy-MM-ddTHH:mm:ss")).Append('"');
            }
            else
            {
                jsonBuilder.Append(obj);
            }
        }

        private static void ConvertToArray(Array obj, StringBuilder jsonBuilder)
        {
            jsonBuilder.Append('[');
            bool isFirst = true;
            foreach( var item in obj )
            {
                if (!isFirst)
                {
                    jsonBuilder.Append(",");
                }
                if (item.GetType().IsPrimitive)
                {
                    AppendToPrimitive(item, jsonBuilder);
                }
                else
                {
                    ObjectTojsonConverter(item, jsonBuilder);
                }
                isFirst = false;
            }
            jsonBuilder.Append("]");
        }

        private static void ConvertToCollection(IEnumerable collection,  StringBuilder jsonBuilder)
        {
            bool isFirst = true;
            jsonBuilder.Append("[");
            foreach( var item in collection)
            {
                if (!isFirst)
                {
                    jsonBuilder.Append(',');
                }
                ObjectTojsonConverter(item, jsonBuilder);
                isFirst = false;
            }
            jsonBuilder.Append("]");
        }

        private static void ConvertToObject(object obj, StringBuilder jsonBuilder)
        {
            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties();

            jsonBuilder.Append('{');
            bool isFirst = true;
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property);
                if (!isFirst)
                {
                    jsonBuilder.Append(",");
                }
                jsonBuilder.Append('"').Append(property.Name).Append("\":");

                object? propertyValue = property.GetValue(obj, null);
                if (propertyValue != null)
                {
                    ObjectTojsonConverter(propertyValue, jsonBuilder);
                }
                else
                {
                    jsonBuilder.Append("null");
                }

                isFirst = false;
            }
            jsonBuilder.Append("}");
        }
    }
}
