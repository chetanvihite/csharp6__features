using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6
{
    class _008_ExceptionFilters
    {
        private static string ShowHex(string value)
        {
            string hexString = null;
            // Handle only non-control characters. 
            if (!Char.IsControl(value, 0))
            {
                foreach (var ch in value)
                    hexString += String.Format("0x{0} ", Convert.ToUInt16(ch));

            }
            return hexString.Trim();
        }
        async Task<string> Close()
        {
            Random rnd = new Random();
            await Task.Factory.StartNew(() =>
            {
                int utf32 = 0;
                lock (rnd)
                {
                    // Get UTF32 value.
                    utf32 = rnd.Next(0, 0xE01F0);
                }
                // Convert it to a UTF16-encoded character. 
                string utf16 = Char.ConvertFromUtf32(utf32);
                // Display information about the character.
                return ShowHex(utf16);

            }); return string.Empty;
        }
        async Task<string> LogError()
        {
            Random rnd = new Random();
            await Task.Factory.StartNew(() =>
            {
                int utf32 = 0;
                lock (rnd)
                {
                    // Get UTF32 value.
                    utf32 = rnd.Next(0, 0xE01F0);
                }
                // Convert it to a UTF16-encoded character. 
                string utf16 = Char.ConvertFromUtf32(utf32);
                // Display information about the character.
                return ShowHex(utf16);
                                  
            }); return string.Empty;
        }
        public void Process()
        {
            try
            {

            }
            catch (ConfigurationException e) when (e.Message != null)
            {
                LogError();
                throw;
            }
        }

        public async void ProcessAsync()
        {
            try
            {

            }
            catch (ConfigurationException e) when (e.Message != null)
            {
                await LogError();
                throw;
            }
            finally
            {
                await Close();
            }
        }
    }
}
