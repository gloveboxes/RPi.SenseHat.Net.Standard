using Emmellsoft.IoT.Rpi.SenseHat;
using RPi.SenseHat.Demo.Demos;

namespace RPi.SenseHat.Demo
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ISenseHat senseHat = SenseHatFactory.GetSenseHat();

			// DiscoLights dl = new DiscoLights(senseHat);
			// dl.Run();

			// MultiColorScrollText colorScroll = new MultiColorScrollText(senseHat, "Hello Raspberry Pi 3 Sense HAT!");
			// colorScroll.Run();

			// SpriteAnimation mario = new SpriteAnimation(senseHat);
			// mario.Run();

			// BinaryClock bc = new BinaryClock(senseHat, null);
			// bc.Run();

			// Compass compass = new Compass(senseHat, null);
			// compass.Run();

			// GravityBlob gb = new GravityBlob(senseHat, null);
			// gb.Run();

			// JoystickPixel js = new JoystickPixel(senseHat, null);
			// js.Run();

			// ReadAllSensors ras = new ReadAllSensors(senseHat, null);
			// ras.Run();

			// SingleColorScrollText scroll = new SingleColorScrollText(senseHat, "Hello Raspberry Pi 3 Sense HAT!");
			// scroll.Run();

			WriteTemperature wt = new WriteTemperature(senseHat, null);
			wt.Run();
		}
	}
}
