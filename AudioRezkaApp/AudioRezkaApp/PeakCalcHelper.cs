using System.Diagnostics;

namespace AudioRezkaApp {
    internal class PeakCalcHelper {
        static float GetPeakValue8(ReadOnlySpan<byte> pcm) {
            var max = int.MinValue;
            var min = int.MaxValue;

            for(var i = 0; i < pcm.Length; i += 1) {
                var sample = (int)((pcm[i + 0] - 128) << 24);
                if(sample > max) {
                    max = sample;
                }
                if(sample < min) {
                    min = sample;
                }
            }
            var fl0 = max / (16_777_216f * 128f);
            var fl1 = min / (-16_777_216f * 128f);
            var flMax = Math.Max(fl0, fl1);
            if(flMax > 1.0f) {
                Debug.WriteLine($"GetPeakValue8 over:{flMax}");
            }
            return Math.Min(flMax, 1.0f);
        }

        static float GetPeakValue16(ReadOnlySpan<byte> pcm) {
            var max = int.MinValue;
            var min = int.MaxValue;

            for(var i = 0; i < pcm.Length; i += 2) {
                var sample = (int)((pcm[i + 1] << 24) | (pcm[i + 0] << 16));
                if(sample > max) {
                    max = sample;
                }
                if(sample < min) {
                    min = sample;
                }
            }
            var fl0 = max / (65536f * 32768f);
            var fl1 = min / (-65536f * 32768f);
            var flMax = Math.Max(fl0, fl1);
            if(flMax > 1.0f) {
                Debug.WriteLine($"GetPeakValue16 over:{flMax}");
            }
            return Math.Min(flMax, 1.0f);
        }

        static float GetPeakValue24(ReadOnlySpan<byte> pcm) {
            var max = int.MinValue;
            var min = int.MaxValue;

            for(var i = 0; i < pcm.Length; i += 3) {
                var sample = (int)((pcm[i + 2] << 24) | (pcm[i + 1] << 16) | (pcm[i + 0] << 8));
                if(sample > max) {
                    max = sample;
                }
                if(sample < min) {
                    min = sample;
                }
            }
            var fl0 = max / (256f * 8_388_608f);
            var fl1 = min / (-256f * 8_388_608f);
            var flMax = Math.Max(fl0, fl1);
            if(flMax > 1.0f) {
                Debug.WriteLine($"GetPeakValue24 over:{flMax}");
            }
            return Math.Min(flMax, 1.0f);
        }

        static float GetPeakValue32(ReadOnlySpan<byte> pcm) {
            var max = int.MinValue;
            var min = int.MaxValue;

            for(var i = 0; i < pcm.Length; i += 4) {
                var sample = (int)((pcm[i + 3] << 24) | (pcm[i + 2] << 16) | (pcm[i + 1] << 8) | pcm[i + 0]);
                if(sample > max) {
                    max = sample;
                }
                if(sample < min) {
                    min = sample;
                }
            }
            var fl0 = max / (1f * 2_147_483_648f);
            var fl1 = min / (-1f * 2_147_483_648f);
            var flMax = Math.Max(fl0, fl1);
            if(flMax > 1.0f) {
                Debug.WriteLine($"GetPeakValue32 over:{flMax}");
            }
            return Math.Min(flMax, 1.0f);
        }

        public static float GetPeak(int bitsPerSample, ReadOnlySpan<byte> pcm) {
            switch(bitsPerSample) {
                case 8:
                    return GetPeakValue8(pcm);
                case 16:
                    return GetPeakValue16(pcm);
                case 24:
                    return GetPeakValue24(pcm);
                case 32:
                    return GetPeakValue32(pcm);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
