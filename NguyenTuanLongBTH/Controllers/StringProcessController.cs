﻿using System.Text.RegularExpressions;

namespace NguyenTuanLongBTH.Models
{
    public class StringProcess
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
            strInput = strInput.Trim();
            int index = strInput.IndexOf("  ");
            while (index > 0)
            {
                strInput = strInput.Replace("  ", " ");
            }
            return strInput;
        }
        public string LowerToUpper(string strInput)
        {
            string result = "";
            //chuyen sang in hoa
            strInput = strInput.ToUpper();
            result = strInput;
            return result;
        }
        public string UpperToLower(string strInput)
        {
            string result = "";
            //chuyen sang in thuong
            strInput = strInput.ToLower();
            result = strInput;
            return result;
        }
        public string CapitalizeOneFirstCharacter(string strInput)
        {
            string result = "";
            //viet hoa chu cai dau tien cua chuoi
            string firstCharacter = strInput.Substring(0, 1).ToUpper();
            strInput = firstCharacter + strInput.Substring(1);
            result = strInput;
            return result;
        }
        public string CapitalizeFirstCharacter(string strInput)
        {

            //viet hoa chu cai dau tien cua chuoi
            string result = "";
            string[] chuoi = strInput.Split(" ");
            result = strInput;
            return result;
        }
        public string RemoveVietnameseAccents(string strInput)
        {
            string Result = "";
            // xóa dấu tiếng việt
            string chuoi = strInput.ToLower();
            chuoi = Regex.Replace(chuoi, "à|á|ả|ã|ạ|ă|ằ|ắ|ẳ|ẵ|ặ|â|ầ|ấ|ẩ|ẫ|ậ|/g", "a");
            chuoi = Regex.Replace(chuoi, "đ", "d");
            chuoi = Regex.Replace(chuoi, "è|é|ẻ|ẽ|ẹ|ê|ề|ế|ể|ễ|ệ/g", "e");
            chuoi = Regex.Replace(chuoi, "ì|í|ỉ|ĩ|ị/g", "i");
            chuoi = Regex.Replace(chuoi, "ò|ó|ỏ|õ|ọ|ô|ồ|ố|ổ|ỗ|ộ|ơ|ờ|ớ|ở|ỡ|ợ/g", "o");
            chuoi = Regex.Replace(chuoi, "ù|ù|ú|ủ|ũ|ụ|ư|ừ|ứ|ử|ữ|ự/g", "a");
            chuoi = Regex.Replace(chuoi, "ỳ|ý|ỷ|ỹ|ỵ/g", "a");
            return Result;
        }
    }
}