﻿using System;

namespace Concordia.Modules.Status
{
    public class Settings
    {
        public DateTimeOffset LastUpdate { get; set; } = DateTimeOffset.UtcNow;
        public ulong? Channel { get; set; }
    }
}
