using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretText
{
    class Pressmark
    {
        private string Key { get; set; }
        private string PromptKey { get; set; }
        public string abc = "abcdefghijklmnopqrstuvwxyz";
        public string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string abc_ru = "абвгдеёжзийклмнопрстуфхцчшщъьэюя";
        public string ABC_ru = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЭЮЯ";
        public string num = "0123456789";


        public Pressmark(string key)
        {
            Key = key;
        }

        public string Encoding(string text)
        {
            string result = "";
            PromptKey = Key;
            while (PromptKey.Length < text.Length)
            {
                PromptKey += Key;
            }
            if (PromptKey.Length > text.Length)
            {
                int lenTxt = PromptKey.Length - text.Length;
                for (int i = 0; i < lenTxt; i++)
                {
                    PromptKey += Key[i];
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                int indexof_a = abc.IndexOf(text[i]);
                int indexof_A = ABC.IndexOf(text[i]);
                int indexof_a_ru = abc_ru.IndexOf(text[i]);
                int indexof_A_ru = ABC_ru.IndexOf(text[i]);
                int indexof_num = num.IndexOf(text[i]);
                if (indexof_num != -1)
                {
                    int offset = num.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48);
                    if (offset >= num.Length)
                        offset = offset - num.Length;
                    else if (offset < 0)
                        offset = num.Length + offset;
                    result += num[offset];
                }
                if (indexof_a != -1)
                {
                    int offset = abc.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48); // вычитаем 48 для того чтобы перевести в число
                    if (offset >= abc.Length)
                        offset = offset - abc.Length;
                    else if (offset < 0)
                        offset = abc.Length + offset;
                    result += abc[offset];
                }
                if (indexof_A != -1)
                {
                    int offset = ABC.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48);
                    if (offset >= ABC.Length)
                        offset = offset - ABC.Length;
                    else if (offset < 0)
                        offset = ABC.Length + offset;
                    result += ABC[offset];
                }
                if (indexof_a_ru != -1)
                {
                    int offset = abc_ru.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48);
                    if (offset >= abc_ru.Length)
                        offset = offset - abc_ru.Length;
                    else if (offset < 0)
                        offset = abc_ru.Length + offset;
                    result += abc_ru[offset];
                }
                if (indexof_A_ru != -1)
                {
                    int offset = ABC_ru.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48);
                    if (offset >= ABC_ru.Length)
                        offset = offset - ABC_ru.Length;
                    else if (offset < 0)
                        offset = ABC_ru.Length + offset;
                    result += ABC_ru[offset];
                }
                if (indexof_a == -1 && indexof_A == -1 && indexof_a_ru == -1 && indexof_A_ru == -1&&indexof_num == -1)
                    result += text[i];

            }
            return result;
        }

        public string Decoding(string text)
        {
            string result = "";
            PromptKey = Key;
            while (PromptKey.Length < text.Length)
            {
                PromptKey += Key;
            }
            if (PromptKey.Length > text.Length)
            {
                int lenTxt = PromptKey.Length - text.Length;
                for (int i = 0; i < lenTxt; i++)
                {
                    PromptKey += Key[i];
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                int indexof_a = abc.IndexOf(text[i]);
                int indexof_A = ABC.IndexOf(text[i]);
                int indexof_a_ru = abc_ru.IndexOf(text[i]);
                int indexof_A_ru = ABC_ru.IndexOf(text[i]);
                int indexof_num = num.IndexOf(text[i]);
                if (indexof_num != -1)
                {
                    int offset = num.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48);
                    if (offset >= num.Length)
                        offset = offset - num.Length;
                    else if (offset < 0)
                        offset = num.Length + offset;
                    result += num[offset];
                }
                if (indexof_a != -1)
                {
                    int offset = abc.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48)*-1; // вычитаем 48 для того чтобы перевести в число
                    if (offset >= abc.Length)
                        offset = offset - abc.Length;
                    else if (offset < 0)
                        offset = abc.Length + offset;
                    result += abc[offset];
                }
                if (indexof_A != -1)
                {
                    int offset = ABC.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48)*-1;
                    if (offset >= ABC.Length)
                        offset = offset - ABC.Length;
                    else if (offset < 0)
                        offset = ABC.Length + offset;
                    result += ABC[offset];
                }
                if (indexof_a_ru != -1)
                {
                    int offset = abc_ru.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48)*-1;
                    if (offset >= abc_ru.Length)
                        offset = offset - abc_ru.Length;
                    else if (offset < 0)
                        offset = abc_ru.Length + offset;
                    result += abc_ru[offset];
                }
                if (indexof_A_ru != -1)
                {
                    int offset = ABC_ru.IndexOf(text[i]) + (Convert.ToInt32(PromptKey[i]) - 48)*-1;
                    if (offset >= ABC_ru.Length)
                        offset = offset - ABC_ru.Length;
                    else if (offset < 0)
                        offset = ABC_ru.Length + offset;
                    result += ABC_ru[offset];
                }
                if (indexof_a == -1 && indexof_A == -1 && indexof_a_ru == -1 && indexof_A_ru == -1 && indexof_num == -1)
                    result += text[i];

            }
            return result;
        }
    }
}
