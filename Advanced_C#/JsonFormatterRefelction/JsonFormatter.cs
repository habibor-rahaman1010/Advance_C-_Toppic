using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JsonFormatterRefelction
{
    public class JsonFormatter
    {
        public static string Convert(object obj)
        {
            if (obj == null)
            {
                return "null";
            }

            var type = obj.GetType();

            if (IsPrimitiveType(type))
            {
                return GetPrimitiveValueJson(obj);
            }

            if (type.IsArray)
            {
                return SerializeArray((Array)obj);
            }

            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                return SerializeList((List<object>)obj);
            }

            return SerializeObject(obj);
        }

        private static string SerializeObject(object obj)
        {
            var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (properties.Length == 0)
            {
                return "{}";
            }

            var sb = new StringBuilder();
            sb.Append("{");

            for (int i = 0; i < properties.Length; i++)
            {
                var property = properties[i];
                var value = property.GetValue(obj);

                sb.Append($"\"{property.Name}\":{Convert(value)}");

                if (i < properties.Length - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("}");
            return sb.ToString();
        }

        private static string SerializeArray(Array array)
        {
            var sb = new StringBuilder();
            sb.Append("[");

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(Convert(array.GetValue(i)));

                if (i < array.Length - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]");
            return sb.ToString();
        }

        private static string SerializeList(List<object> list)
        {
            return SerializeArray(list.ToArray()); // Leverage array serialization for simplicity
        }

        private static string GetPrimitiveValueJson(object value)
        {
            if (value is string str)
            {
                var sb = new StringBuilder();
                sb.Append("\"");
                sb.Append(str.EscapeForJson());
                sb.Append("\"");
                return sb.ToString();
            }
            else if (value is DateTime dateTime)
            {
                return $"\"{dateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}\""; // ISO 8601 format
            }
            else
            {
                return value.ToString();
            }
        }

        private static bool IsPrimitiveType(Type type)
        {
            return type.IsPrimitive ||
                   type == typeof(string) ||
                   type == typeof(decimal) ||
                   type == typeof(DateTime);
        }
    }

    public static class StringExtensions
    {
        public static string EscapeForJson(this string str)
        {
            return str.Replace("\"", "\\\"")
                      .Replace("\\", "\\\\")
                      .Replace("\b", "\\b")
                      .Replace("\t", "\\t")
                      .Replace("\n", "\\n")
                      .Replace("\r", "\\r")
                      .Replace("\f", "\\f");
        }
    }
}
