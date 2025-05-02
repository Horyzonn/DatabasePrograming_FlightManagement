using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL
{
    public class VNPayService
    {
        private static string vnp_TmnCode = "NKJQOFMA";  // Mã website (vnp_TmnCode)
        private static string vnp_HashSecret = "G1IT7OSKL4M5R31F1T0GT7PIL5AYNTQ2";  // Secret Key (vnp_HashSecret)
        private static string vnp_Url = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html";  // URL thanh toán trong môi trường TEST (vnp_Url)
        private static string vnp_ReturnUrl = "http://yourwebsite.com/return";  // URL để nhận kết quả thanh toán

        public static string CreatePaymentUrl(string orderId, decimal amount, string clientIp)
        {
            var vnp_Params = new SortedDictionary<string, string>
        {
            { "vnp_Version", "2.1.0" },
            { "vnp_Command", "pay" },
            { "vnp_TmnCode", vnp_TmnCode },
            { "vnp_Amount", ((int)(amount * 100)).ToString() },
            { "vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss") },
            { "vnp_CurrCode", "VND" },
            { "vnp_IpAddr", clientIp },
            { "vnp_Locale", "vn" },
            { "vnp_OrderInfo", $"Thanh toan don hang: {orderId}" },
            { "vnp_OrderType", "other" },
            { "vnp_ReturnUrl", vnp_ReturnUrl },
            { "vnp_ExpireDate", DateTime.Now.AddMinutes(15).ToString("yyyyMMddHHmmss") },
            { "vnp_TxnRef", orderId }
        };

            string rawData = string.Join("&", vnp_Params.Select(kvp => $"{kvp.Key}={kvp.Value}"));
            string secureHash = ComputeSha256(vnp_HashSecret + rawData);
            vnp_Params.Add("vnp_SecureHash", secureHash);

            string queryString = string.Join("&", vnp_Params.Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));
            return $"{vnp_Url}?{queryString}";
        }

        private static string ComputeSha256(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToUpper();
            }
        }
        private static string GetIpAddress()
        {
            // Đoạn code này có thể lấy IP từ người dùng qua request nếu ứng dụng của bạn hỗ trợ
            return "127.0.0.1";  // Chỉ là ví dụ, thay bằng IP thực của người dùng trong thực tế
        }
    }
}
