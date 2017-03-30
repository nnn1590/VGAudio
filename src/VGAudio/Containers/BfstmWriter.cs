﻿using System.IO;
using VGAudio.Containers.Bxstm;
using VGAudio.Formats;

namespace VGAudio.Containers
{
    public class BfstmWriter : AudioWriter<BfstmWriter, BfstmConfiguration>
    {
        private BCFstmWriter Writer { get; set; }

        protected override int FileSize => Writer.FileSize;
        protected override void SetupWriter(AudioData audio)
        {
            Writer = new BCFstmWriter(Configuration);
            Writer.SetupWriter(audio);
        }

        protected override void WriteStream(Stream stream) => Writer.WriteStream(stream);
    }
}