using System.Text;

namespace ristretto.Extensions
{
    internal static class EncodeStringExtension
    {
        public static string Encode(this string plainText)
        {
            _ = plainText ?? throw new ArgumentNullException(nameof(plainText));

            byte[] textAsBytes = Encoding.UTF8.GetBytes(plainText);
           
            return Convert.ToBase64String(textAsBytes);
        }
    }
}
