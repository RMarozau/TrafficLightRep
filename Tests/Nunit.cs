using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using TrafficLight;
using Bogus;

namespace Tests
{
    public class Nunit
    {
        SourceOfPower SourceOfPower;
        TrafficLight.TrafficLight trafficLight;
        TrafficLight.TrafficLightColor trafficLightColor;

        [SetUp]
        public void Setup_SourceOfPower()
        {
            SourceOfPower = new SourceOfPower();

        }

        [Test]
        public void SourceOfPower_Test_Shold_Be()
        {
         
            bool active = SourceOfPower.GetElectrisity();
            active.Should().Be(SourceOfPower.Electriсity, because: $"Для работы световора, источник питания должен быть = {SourceOfPower.Electriсity}");
        }

        [Test]
        public void Random_bool_Test_For_SourceOfPower()
        {
            var faker = new Faker<SourceOfPower>();

            faker.RuleFor(f => f.Electriсity, f => f.Random.Bool());

            var sourcerOfPower = faker.Generate();

            trafficLight = new TrafficLight.TrafficLight(sourcerOfPower);
            
        }
        
        [Test]
        [TestCase(TrafficLightColor.Colors.Green)]
        [TestCase(TrafficLightColor.Colors.Red)]
        public void Color_Test_Shold_Be(TrafficLightColor.Colors color)
        {
            color.Should().Be(color, because: $"Для работы класса TrafficLight, цвет должен должен быть = {color}");
        }
    }
}
