using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Number_system.Properties
{
    class Translation_Numbers
    {
        private int[] arr;
        private int Input;
        private string Conclusion;

        private void Convert_in_arr(string str)
        {
            arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = Int32.Parse(str.Substring(i, 1));
            }
        }


        private bool Chek (int Numerat_Input)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= Numerat_Input)
                {
                    Conclusion = "Ошибка!";
                    return true;
                }
            }
            return false;
        }


        private void in_decimal(int Numerat_Input)
        {
            Input = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                       Input += arr[i] * (int)Math.Pow(Numerat_Input, (arr.Length-i-1));
                    }
                }
                
        }

        private void in_binari (int Numerat_Conclusion)
        {
            int temp = 0;
            List<int> temp_arr = new List<int>();
            while (Input > 0)
            {
                temp = Input % Numerat_Conclusion;
                Input = Input / Numerat_Conclusion;
                temp_arr.Add(temp);
            }
            obrat(temp_arr);
        }
        
        private void obrat(List<int> norm)
        {
            arr = new int[norm.Count];
            for (int i = norm.Count - 1; i >= 0; i--)
            {
                arr[norm.Count - 1 - i] = norm[i];
            }
            
        }

        //Формирует порядок использования функций 
        public string Scheme_transfer(int Numerat_Input, int Numerat_Conclusion, string str)
        {
            Convert_in_arr(str);
            if (!Chek(Numerat_Input))
            {
                Conclusion = null;
                if (Numerat_Input != 10)
                {
                    in_decimal(Numerat_Input);
                    if (Numerat_Conclusion != 10)
                    {
                        in_binari(Numerat_Conclusion);
                        Conclusion = String.Join("", arr);
                    }
                    else
                        Conclusion = Input.ToString();

                }
                else
                {
                    Input = Int32.Parse(str);
                    arr = null;
                    if (Numerat_Conclusion != 10)
                    {
                        in_binari(Numerat_Conclusion);
                        Conclusion = String.Join("", arr);
                    }
                    else
                        Conclusion = Input.ToString();
                }

            }
            return Conclusion;
        }


    } 

}
