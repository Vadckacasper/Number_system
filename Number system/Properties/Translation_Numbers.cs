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
        public int Conclusion = 0;
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
                    return true;
            }
            return false;
        }

        public void Scheme_transfer (int Numerat_Input, int Numerat_Conclusion, string str)
        {
            Convert_in_arr(str);
            if (!Chek(Numerat_Input)) 
            {
                if (Numerat_Input < Numerat_Conclusion)
                {
                    
                    in_Numerat(Numerat_Input);
                }
                if (Numerat_Input > Numerat_Conclusion)
                {
                    Input = Int32.Parse(str);
                }


            }
        }

        private void in_Numerat (int Numerat_Input)
        {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        Conclusion += arr[i] * (int)Math.Pow(Numerat_Input, (arr.Length-i-1));
                    }
                }
        }



    } 

}
