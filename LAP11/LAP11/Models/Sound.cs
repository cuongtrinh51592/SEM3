﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP11.Models
{
    public class Sound
    {
        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = String.Format("/Assets/Audio/{0}/{1}.wav", category, name);
            ImageFile = String.Format("/Assets/Images/{0}/{1}.png", category, name);
        }

        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }
    }

    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
}
