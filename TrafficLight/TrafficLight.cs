using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TrafficLight
{
    public class TrafficLight
    {
        public TrafficLightColor _trafficLightColor;
        public TrafficLightTime _trafficLightTime;
        public SourceOfPower _sourceOfPower;
        public int Second;
        /// <summary>
        /// Инициализация цвета, времени, и включенного источника питания по умолчанию
        /// </summary>
        public TrafficLight()
        {
            _trafficLightColor = new TrafficLightColor(TrafficLightColor.Colors.Red);
            _trafficLightTime = new TrafficLightTime(10);
            this.Second = _trafficLightTime.Second;
            _sourceOfPower = new SourceOfPower(true);
            if (_sourceOfPower.GetElectrisity() == true)
            {
                StartTimer(new Timer(1000));

            }
        }
        /// <summary>
        /// SourceOfPower либо false, либо true;
        /// </summary>
        /// <param name="source"></param>
        public TrafficLight(SourceOfPower source)
        {
            
            _trafficLightColor = new TrafficLightColor(TrafficLightColor.Colors.Red);
            _trafficLightTime = new TrafficLightTime(10);
            this.Second = _trafficLightTime.Second;
            if (source.GetElectrisity() == true)
            {
                StartTimer(new Timer(1000));

            }
        }
        /// <summary>
        /// Ввод всех параметров вручную, где source - источник питания, TrafficLightColor - цвет с которого нужно начать работу светофора, trafficLightTime - время работы красной и зеленой лампы
        /// </summary>
        /// <param name="source"></param>
        /// <param name="TrafficLightColor"></param>
        /// <param name="trafficLightTime"></param>
        public TrafficLight(SourceOfPower source, TrafficLightColor TrafficLightColor, TrafficLightTime trafficLightTime)
        {

            this._trafficLightColor = TrafficLightColor;
            this.Second = trafficLightTime.Second;
            this._trafficLightTime = trafficLightTime;
           // _trafficLightTime = new TrafficLightTime(10);
            if (source.GetElectrisity() == true)
            {
                StartTimer(new Timer(1000));

            }
        }

        /// <summary>
        /// Логика световора.Цвет меняеться в зависимости от времнени секундомера.
        /// </summary>
        public void LogicTrafficLight()
        {
             
            if (_trafficLightTime.Second == 3)
            {
                _trafficLightColor.SetNowColor(TrafficLightColor.Colors.Yellow);
            }
            if (_trafficLightTime.Second == 0 && _trafficLightColor.PredColor == TrafficLightColor.Colors.Green)
            {
                _trafficLightColor.SetNowColor(TrafficLightColor.Colors.Green);
                _trafficLightColor.SetPredColor(TrafficLightColor.Colors.Red);
                _trafficLightTime.SetSecond(Second);
            }
            if (_trafficLightTime.Second == 0 && _trafficLightColor.PredColor == TrafficLightColor.Colors.Red)
            {
                _trafficLightColor.SetNowColor(TrafficLightColor.Colors.Red);
                _trafficLightColor.SetPredColor(TrafficLightColor.Colors.Green);
                _trafficLightTime.SetSecond(Second);
            }
            _trafficLightTime.Second--;
        }
        /// <summary>
        /// Старт таймера который запускает событие в коснольном приложении.
        /// </summary>
        /// <param name="aTimer"></param>
        private void StartTimer(System.Timers.Timer aTimer)
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            LogicTrafficLight();
            if (_trafficLightColor.NowColor == TrafficLightColor.Colors.Green)
            {
                Console.WriteLine($"Цвет светофора Зеленый, Поехали!: {_trafficLightTime.Second}");
            }
            else if (_trafficLightColor.NowColor == TrafficLightColor.Colors.Red)
            {
                Console.WriteLine($"Цвет светофора Красный, Стоим!: {_trafficLightTime.Second}");
            }
            else if (_trafficLightColor.NowColor == TrafficLightColor.Colors.Yellow && _trafficLightColor.PredColor == TrafficLightColor.Colors.Red)
            {
                Console.WriteLine($"Цвет светофора Желтый, Приготовились остановиться!: {_trafficLightTime.Second}");
            }
            else if (_trafficLightColor.NowColor == TrafficLightColor.Colors.Yellow && _trafficLightColor.PredColor == TrafficLightColor.Colors.Green)
            {
                Console.WriteLine($"Цвет светофора Желтый, Приготовились ехать!: {_trafficLightTime.Second}");
            }
            
        }
        

    }

        
    
   

}
