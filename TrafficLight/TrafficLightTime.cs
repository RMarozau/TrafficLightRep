using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    public class TrafficLightTime
    {
        public int Second;

        /// <summary>
        /// Конструктор для установки времени светофора
        /// </summary>
        /// <param name="_second"></param>
        public TrafficLightTime(int _second)
        {
            Second = _second;
        }
        /// <summary>
        /// Установка нового времени светофора
        /// </summary>
        /// <param name="_second"></param>
        public void SetSecond(int _second)
        {
            Second = _second;
        }


    }
}
