using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    public class TrafficLightColor
    {
        public enum Colors { Red, Green, Yellow }

        public Colors NowColor;

        public Colors PredColor;
        /// <summary>
        /// Выбор цвета с которого начнет свою работу светофор
        /// </summary>
        /// <param name="color"></param>
        public TrafficLightColor(Colors color)
        {
            if (color == Colors.Red)
            {
                NowColor = Colors.Red;
                PredColor = Colors.Green;
            }
            else
            {
                NowColor = Colors.Green;
                PredColor = Colors.Red;
            }
        }
        /// <summary>
        /// Установка текущего цвета
        /// </summary>
        /// <param name="_nowColor"></param>
        public void SetNowColor(Colors _nowColor)
        {
            NowColor = _nowColor;
        }
        /// <summary>
        /// Установка предыдущего цвета
        /// </summary>
        /// <param name="_predColor"></param>
        public void SetPredColor(Colors _predColor)
        {
            PredColor = _predColor;
        }
    }
}
