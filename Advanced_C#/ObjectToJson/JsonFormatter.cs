using System;
using System.Collections;
using System.Text;
using System.Reflection;

namespace ObjectToJson
{
    public static class JsonFormatter
    {
        public static string Convert(object item)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            ConvertItem(item, jsonBuilder);
            return jsonBuilder.ToString();
        }

        private static void ConvertItem(object item, StringBuilder jsonBuilder)
        {
            if (item == null)
            {
                jsonBuilder.Append("null");
                return;
            }

            Type itemType = item.GetType();

            if (itemType.IsPrimitive || itemType == typeof(string) || itemType == typeof(DateTime))
            {
                AppendPrimitiveValue(item, jsonBuilder);
            }
            else if (itemType.IsArray)
            {
                ConvertArray((Array)item, jsonBuilder);
            }
            else if (item is IEnumerable enumerable)
            {
                ConvertCollection(enumerable, jsonBuilder);
            }
            else
            {
                ConvertObject(item, jsonBuilder);
            }
        }

        private static void AppendPrimitiveValue(object value, StringBuilder jsonBuilder)
        {
            if (value is string)
            {
                jsonBuilder.Append('"');
                jsonBuilder.Append(value);
                jsonBuilder.Append('"');
            }
            else if (value is DateTime dateTime)
            {
                jsonBuilder.Append('"');
                jsonBuilder.Append(dateTime.ToString("yyyy-MM-ddTHH:mm:ss"));
                jsonBuilder.Append('"');
            }
            else
            {
                jsonBuilder.Append(value);
            }
        }

        private static void ConvertArray(Array array, StringBuilder jsonBuilder)
        {
            jsonBuilder.Append("[");
            bool isFirst = true;

            foreach (var item in array)
            {
                if (!isFirst)
                {
                    jsonBuilder.Append(",");
                }
                ConvertItem(item, jsonBuilder);
                isFirst = false;
            }

            jsonBuilder.Append("]");
        }

        private static void ConvertCollection(IEnumerable collection, StringBuilder jsonBuilder)
        {
            jsonBuilder.Append("[");
            bool isFirst = true;

            foreach (var item in collection)
            {
                if (!isFirst)
                {
                    jsonBuilder.Append(",");
                }
                ConvertItem(item, jsonBuilder);
                isFirst = false;
            }

            jsonBuilder.Append("]");
        }

        private static void ConvertObject(object obj, StringBuilder jsonBuilder)
        {
            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties();

            jsonBuilder.Append("{");
            bool isFirst = true;

            foreach (PropertyInfo property in properties)
            {
                if (!isFirst)
                {
                    jsonBuilder.Append(",");
                }

                jsonBuilder.Append("\"");
                jsonBuilder.Append(property.Name);
                jsonBuilder.Append("\":");

                object? propertyValue = property.GetValue(obj);
                if (propertyValue != null)
                {
                    ConvertItem(propertyValue, jsonBuilder);
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