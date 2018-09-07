using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleBuffer
{
    public class BufferdConsole : IDisposable
    {
        private StreamWriter stringWriter;
        private const int MaxBufferSize = 50;
        private byte[] buffer;
        private int index;

        public BufferdConsole()
        {
            this.buffer = new byte[MaxBufferSize];
            this.stringWriter = new StreamWriter(new FileStream("./Results.txt", FileMode.OpenOrCreate, FileAccess.Write));
        }

        public void Write(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            if(bytes.Length + this.index >= MaxBufferSize)
            {
                string bufferString = Encoding
                    .Default
                    .GetString(this.buffer
                    .Take(index)
                    .ToArray());

                string result = bufferString + text;

                this.stringWriter.Write(result);

                this.index = 0;
                return;
            }

            foreach (byte @byte in bytes)
            {
                this.buffer[this.index++] = @byte;
            }
        }

        public void Dispose()
        {
            this.stringWriter.Close();
        }
    }
}
