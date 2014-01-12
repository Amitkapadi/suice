﻿using System;

namespace Toolbox.Injection
{
    /// <summary>
    /// Dependencies implement this if require initialization
    /// 
    /// @author DisTurBinG
    /// </summary>
    public interface InitializeDependency
    {
        void Initialize();
    }
}