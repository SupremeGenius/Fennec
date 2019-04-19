using CSCore.CoreAudioAPI;
using System;

namespace Fennec.Watchers
{
    namespace AudioPlayingTest
    {
        class AudioPlayChecker
        {
            // Gets the default device for the system
            public static MMDevice GetDefaultRenderDevice()
            {
                using (var enumerator = new MMDeviceEnumerator())
                {
                    return enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                }
            }

            // Checks if audio is playing on a certain device
            public static bool IsAudioPlaying(MMDevice device)
            {
                using (var meter = AudioMeterInformation.FromDevice(device))
                {
                    return meter.PeakValue > 0;
                }
            }

            /*  
            static void Main(string[] args)
            {
                Console.WriteLine(IsAudioPlaying(GetDefaultRenderDevice()));
                Console.ReadLine(); //Just so the console window doesn't close
            }
            */
        }
    }
}
