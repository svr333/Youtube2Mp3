﻿using System.IO;
using System.Threading.Tasks;
using Youtube2Mp3.Core.Entities;

namespace Youtube2Mp3.Core.Services
{
    public interface IStreamRepository
    {
        Task<Stream> GetStreamOfTrack(Track track);
    }
}