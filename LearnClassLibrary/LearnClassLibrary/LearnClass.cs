using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSecunds(int a, int b)
        {
            return a * 3600 + b * 60;
        }
        public (int, int) Secunds(int second)
        {
            int vsemin = second / 60;// ВСЕ МИНУТЫ
            int hours = vsemin/60 ; //ОБЩЕЕ КОЛВО МИНУТ ДЕЛИМ И ПОЛУЧАЕМ ЧАСЫ
            int min = vsemin % 60; //ОСАТОК ОТ ДЕЛЕНИЯ ОБЩЕГО КОЛВА МИНУТ НА 60
           
            return (hours,min);


            
        }

    }
}
